using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;

namespace OfflineARM.View.Validators
{
    /// <summary>
    /// Провайдер валидации 
    /// </summary>
    public class TextEditValidationProvider : DXValidationProvider
    {
        #region поля и свойства

        /// <summary>
        /// Контрол и правило
        /// </summary>
        private readonly Dictionary<Control, List<ValidationRuleBase>> _hashTable = new Dictionary<Control, List<ValidationRuleBase>>();

        /// <summary>
        /// Индикатор
        /// </summary>
        private readonly ErrorProvider _msErrorProvider = new ErrorProvider();

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public TextEditValidationProvider()
        {

        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public TextEditValidationProvider(IContainer container)
            : base(container)
        {

        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public TextEditValidationProvider(ContainerControl parentControl)
            : base(parentControl)
        {

        }

        #endregion

        #region методы

        /// <summary>
        /// Установить правило для контрола
        /// </summary>
        /// <param name="control">Контрол</param>
        /// <param name="rule">Правило</param>
        public override void SetValidationRule(Control control, ValidationRuleBase rule)
        {
            if (control is TextEdit)
            {
                if (_hashTable.ContainsKey(control))
                {
                    _hashTable[control].Add(rule);
                }
                else
                {
                    _hashTable.Add(control, new List<ValidationRuleBase>() { rule });
                }
            }
        }

        /// <summary>
        /// Валидация контрола
        /// </summary>
        /// <param name="control">Контрол</param>
        /// <returns></returns>
        public new bool Validate(Control control)
        {
            if (!_hashTable.ContainsKey(control))
            {
                return true;
            }

            var ctrl = control as TextEdit;
            if (ctrl == null)
            {
                throw new ArgumentException("control must TextEdit");
            }

            foreach (var rule in _hashTable[control])
            {
                if (rule == null || !rule.CanValidate(ctrl))
                {
                    return true;
                }

                if (!rule.Validate(ctrl, ctrl.Text))
                {
                    _msErrorProvider.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleLeft);
                    _msErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    _msErrorProvider.SetError(control, "Введите значение!");
                    return false;
                }
                else
                {
                    _msErrorProvider.SetError(control, "");
                }
            }

            return true;
        }

        /// <summary>
        /// Валидация контрола
        /// </summary>
        /// <returns></returns>
        public new bool Validate()
        {
            var result = true;

            foreach (var control in _hashTable.Keys)
            {
                if (!result)
                {
                    Validate(control);
                }
                else
                {
                    result = Validate(control);
                }
            }

            return result;
        }

        /// <summary>
        /// Сброс значений валидации
        /// </summary>
        public void ResetValidate()
        {
            foreach (var control in _hashTable.Keys)
            {
                _msErrorProvider.SetError(control, "");
            }
        }

        /// <summary>
        /// Сброс значений валидации
        /// </summary>
        public void ResetValidate(Control control)
        {
            _msErrorProvider.SetError(control, "");
        }

        /// <summary>
        /// Удалить контрол из валидации
        /// </summary>
        /// <param name="control"></param>
        public void RemoveControl(Control control)
        {
            if (_hashTable.ContainsKey(control))
            {
                _hashTable.Remove(control);
                ResetValidate(control);
            }
        }

        #endregion

        #region private

        private void SubscribeValidating(Control control)
        {
            control.Validating += control_Validating;
        }

        private void UnsubscribeValidating(Control control)
        {
            control.Validating -= control_Validating;
        }

        private void control_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as TextEdit;
            _msErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _msErrorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleLeft);
            if (!Validate(control))
            {
                _msErrorProvider.SetError(control, "Please enter a valid value");
                e.Cancel = true;
            }
            else
            {
                _msErrorProvider.SetError(control, "");
            }
        }

        #endregion
    }
}
