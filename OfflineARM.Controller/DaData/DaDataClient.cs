using System;
using System.Net;
using RestSharp;

namespace OfflineARM.Controller.DaData 
{
    public class DaDataClient
    {
        #region поля и свойства

        private const string SUGGESTIONS_URL = "{0}/suggest";
        private const string ADDRESS_RESOURCE = "address";
        private const string PARTY_RESOURCE = "party";
        private const string BANK_RESOURCE = "bank";
        private const string FIO_RESOURCE = "fio";
        private const string EMAIL_RESOURCE = "email";

        private readonly RestClient _client;
        private readonly string _token;
        private readonly ContentType _contentType = ContentType.JSON;

        /// <summary>
        /// Прокси
        /// </summary>
        public IWebProxy Proxy
        {
            get
            {
                return _client.Proxy;
            }
            set
            {
                _client.Proxy = value;
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        static DaDataClient()
        {
            // use SSL v3
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="token"></param>
        /// <param name="baseUrl"></param>
        public DaDataClient(string token, string baseUrl)
        {
            this._token = token;
            this._client = new RestClient(String.Format(SUGGESTIONS_URL, baseUrl));
        }

        #endregion

        #region методы

        public SuggestAddressResponse QueryAddress(string address)
        {
            return QueryAddress(new AddressSuggestQuery(address));
        }

        public SuggestAddressResponse QueryAddress(AddressSuggestQuery query)
        {
            var request = new RestRequest(ADDRESS_RESOURCE, Method.POST);
            return Execute<SuggestAddressResponse>(request, query);
        }

        public SuggestBankResponse QueryBank(string bank)
        {
            return QueryBank(new BankSuggestQuery(bank));
        }

        public SuggestBankResponse QueryBank(BankSuggestQuery query)
        {
            var request = new RestRequest(BANK_RESOURCE, Method.POST);
            return Execute<SuggestBankResponse>(request, query);
        }

        public SuggestEmailResponse QueryEmail(string email)
        {
            var request = new RestRequest(EMAIL_RESOURCE, Method.POST);
            var query = new SuggestQuery(email);
            return Execute<SuggestEmailResponse>(request, query);
        }

        public SuggestFioResponse QueryFio(string fio)
        {
            return QueryFio(new FioSuggestQuery(fio));
        }

        public SuggestFioResponse QueryFio(FioSuggestQuery query)
        {
            var request = new RestRequest(FIO_RESOURCE, Method.POST);
            return Execute<SuggestFioResponse>(request, query);
        }

        public SuggestPartyResponse QueryParty(string party)
        {
            return QueryParty(new PartySuggestQuery(party));
        }

        public SuggestPartyResponse QueryParty(PartySuggestQuery query)
        {
            var request = new RestRequest(PARTY_RESOURCE, Method.POST);
            return Execute<SuggestPartyResponse>(request, query);
        }

        private T Execute<T>(RestRequest request, SuggestQuery query) where T : new()
        {
            request.AddHeader("Authorization", "Token " + this._token);
            request.AddHeader("Content-Type", _contentType.Name);
            request.AddHeader("Accept", _contentType.Name);
            request.RequestFormat = _contentType.Format;
            request.XmlSerializer.ContentType = _contentType.Name;
            request.AddBody(query);
            var response = _client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw response.ErrorException;
            }
            return response.Data;
        }

         #endregion
    }
}
