using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace WindowsUiAutomation
{
    public static class AutomationElementExtensions
    {

       

        /// <summary>
        /// Get the text value
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetTextControl(this AutomationElement element)
        {
            object patternObj;
            if (element.TryGetCurrentPattern(ValuePattern.Pattern, out patternObj))
            {
                var valuePattern = (ValuePattern)patternObj;
                return valuePattern.Current.Value;
            }
            else if (element.TryGetCurrentPattern(TextPattern.Pattern, out patternObj))
            {
                var textPattern = (TextPattern)patternObj;
                return textPattern.DocumentRange.GetText(-1).TrimEnd('\r'); // often there is an extra '\r' hanging off the end.
            }
            else
            {
                return element.Current.Name;
            }
        }



        /// <summary>
        /// Invoke specified control
        /// </summary>
        /// <param name="element"></param>
        public static void InvokeControl(this AutomationElement element)
        {
            InvokePattern invokePattern = null;

            try
            {
                invokePattern =
                    element.GetCurrentPattern(InvokePattern.Pattern)
                    as InvokePattern;
            }
            catch (ElementNotEnabledException)
            {
                // Object is not enabled
                return;
            }
            catch (InvalidOperationException)
            {
                // object doesn't support the InvokePattern control pattern
                return;
            }

            invokePattern.Invoke();
            Thread.Sleep(500);
        }



        /// <summary>
        /// Check the if optionButton
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsElementToggledOn(this AutomationElement element)
        {
            if (element == null)
            {
                // TODO: Invalid parameter error handling.
                return false;
            }

            Object objPattern;
            TogglePattern togPattern;
            if (true == element.TryGetCurrentPattern(TogglePattern.Pattern, out objPattern))
            {
                togPattern = objPattern as TogglePattern;
                return togPattern.Current.ToggleState == ToggleState.On;
            }
            // TODO: Object doesn't support TogglePattern error handling.
            return false;
        }



        /// <summary>
        /// Selects the value of comboBox Control
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="item"></param>
        public static void SetSelectedComboBoxItem(this AutomationElement comboBox, string item)
        {
            AutomationPattern automationPatternFromElement = GetSpecifiedPattern(comboBox, "ExpandCollapsePatternIdentifiers.Pattern");

            ExpandCollapsePattern expandCollapsePattern = comboBox.GetCurrentPattern(automationPatternFromElement) as ExpandCollapsePattern;

            expandCollapsePattern.Expand();



            AutomationElement listItem = comboBox.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NameProperty, item));

            InvokeControl(listItem);


            //automationPatternFromElement = GetSpecifiedPattern(listItem, "SelectionItemPatternIdentifiers.Pattern");
            //SelectionItemPattern selectionItemPattern = listItem.GetCurrentPattern(automationPatternFromElement) as SelectionItemPattern;
            //selectionItemPattern.Select();

        }

        private static AutomationPattern GetSpecifiedPattern(AutomationElement element, string patternName)
        {
            AutomationPattern[] supportedPattern = element.GetSupportedPatterns();

            foreach (AutomationPattern pattern in supportedPattern)
            {
                if (pattern.ProgrammaticName == patternName)
                    return pattern;
            }

            return null;
        }


        /// <summary>
        /// Selects the tabItem inside tabControl
        /// </summary>
        /// <param name="tabItem"></param>
        public static void SelectTab(this AutomationElement tabItem)
        {
            SelectionItemPattern activateCountryTab = tabItem.GetCurrentPattern(SelectionItemPattern.Pattern) as SelectionItemPattern;
            activateCountryTab.Select();
        }


    }
}
