using System;
using Telerik.WinControls.UI.Localization;

namespace BGCOP.CAVTOP.WINFORMS.frmtlk
{
	public class MyEnglishRadGridLocalizationProvider : RadGridLocalizationProvider
	{
		public MyEnglishRadGridLocalizationProvider()
		{
		}

		public override string GetLocalizedString(string id)
		{
			string empty;
			string str = id;
			if (str != null)
			{
				switch (str)
				{
					case "FilterFunctionsBetween":
					{
						empty = "Entre";
						break;
					}
					case "FilterFunctionContains":
					{
						empty = "Contiene";
						break;
					}
					case "FilterFunctionDoesNotContain":
					{
						empty = "No contiene";
						break;
					}
					case "FilterFunctionEndsWith":
					{
						empty = "Termina con";
						break;
					}
					case "FilterFunctionEqualTo":
					{
						empty = "Igual";
						break;
					}
					case "FilterFunctionGreaterThan":
					{
						empty = "Mayor que";
						break;
					}
					case "FilterFunctionGreaterThanOrEqualTo":
					{
						empty = "Mayor igual a";
						break;
					}
					case "FilterFunctionIsEmpty":
					{
						empty = "es vacio";
						break;
					}
					case "FilterFunctionIsNull":
					{
						empty = "es null";
						break;
					}
					case "FilterFunctionLessThan":
					{
						empty = "Menor que";
						break;
					}
					case "FilterFunctionLessThanOrEqualTo":
					{
						empty = "Menor igual a";
						break;
					}
					case "FilterFunctionNoFilter":
					{
						empty = "Sin filtro";
						break;
					}
					case "FilterFunctionNotBetween":
					{
						empty = "no esta entre";
						break;
					}
					case "FilterFunctionNotEqualTo":
					{
						empty = "diferente de";
						break;
					}
					case "FilterFunctionNotIsEmpty":
					{
						empty = "No es vacio";
						break;
					}
					case "FilterFunctionNotIsNull":
					{
						empty = "No es nullo";
						break;
					}
					case "FilterFunctionStartsWith":
					{
						empty = "Comienza por";
						break;
					}
					case "FilterFunctionsCustom":
					{
						empty = "Ajuste";
						break;
					}
					case "FilterOperatorBetween":
					{
						empty = "Between";
						break;
					}
					case "FilterOperatorContains":
					{
						empty = "Contains";
						break;
					}
					case "FilterOperatorDoesNotContain":
					{
						empty = "NotContain";
						break;
					}
					case "FilterOperatorEndsWith":
					{
						empty = "EndsWith";
						break;
					}
					case "FilterOperatorEqualTo":
					{
						empty = "Equal";
						break;
					}
					case "FilterOperatorGreaterThan":
					{
						empty = "GreaterThan";
						break;
					}
					case "FilterOperatorGreaterThanOrEqualTo":
					{
						empty = "GreaterThanOrEqual";
						break;
					}
					case "FilterOperatorIsEmpty":
					{
						empty = "IsEmpty";
						break;
					}
					case "FilterOperatorIsNull":
					{
						empty = "IsNull";
						break;
					}
					case "FilterOperatorLessThan":
					{
						empty = "LessThan";
						break;
					}
					case "FilterOperatorLessThanOrEqualTo":
					{
						empty = "LessThanOrEqual";
						break;
					}
					case "FilterOperatorNoFilter":
					{
						empty = "No filter";
						break;
					}
					case "FilterOperatorNotBetween":
					{
						empty = "NotBetween";
						break;
					}
					case "FilterOperatorNotEqualTo":
					{
						empty = "NotEqual";
						break;
					}
					case "FilterOperatorNotIsEmpty":
					{
						empty = "NotEmpty";
						break;
					}
					case "FilterOperatorNotIsNull":
					{
						empty = "NotNull";
						break;
					}
					case "FilterOperatorStartsWith":
					{
						empty = "StartsWith";
						break;
					}
					case "FilterOperatorIsLike":
					{
						empty = "Like";
						break;
					}
					case "FilterOperatorNotIsLike":
					{
						empty = "NotLike";
						break;
					}
					case "FilterOperatorIsContainedIn":
					{
						empty = "ContainedIn";
						break;
					}
					case "FilterOperatorNotIsContainedIn":
					{
						empty = "NotContainedIn";
						break;
					}
					case "FilterOperatorCustom":
					{
						empty = "Custom";
						break;
					}
					case "CustomFilterMenuItem":
					{
						empty = "Custom";
						break;
					}
					case "CustomFilterDialogCaption":
					{
						empty = "RadGridView Filter Dialog";
						break;
					}
					case "CustomFilterDialogLabel":
					{
						empty = "Show rows where:";
						break;
					}
					case "CustomFilterDialogRbAnd":
					{
						empty = "And";
						break;
					}
					case "CustomFilterDialogRbOr":
					{
						empty = "Or";
						break;
					}
					case "CustomFilterDialogBtnOk":
					{
						empty = "OK";
						break;
					}
					case "CustomFilterDialogBtnCancel":
					{
						empty = "Cancel";
						break;
					}
					case "CustomFilterDialogCheckBoxNot":
					{
						empty = "Not";
						break;
					}
					case "CustomFilterDialogTrue":
					{
						empty = "True";
						break;
					}
					case "CustomFilterDialogFalse":
					{
						empty = "False";
						break;
					}
					case "FilterMenuAvailableFilters":
					{
						empty = "Available Filters";
						break;
					}
					case "FilterMenuSearchBoxText":
					{
						empty = "Search...";
						break;
					}
					case "FilterMenuClearFilters":
					{
						empty = "Clear Filter";
						break;
					}
					case "FilterMenuButtonOK":
					{
						empty = "OK";
						break;
					}
					case "FilterMenuButtonCancel":
					{
						empty = "Cancel";
						break;
					}
					case "FilterMenuSelectionAll":
					{
						empty = "All";
						break;
					}
					case "FilterMenuSelectionAllSearched":
					{
						empty = "All Search Result";
						break;
					}
					case "FilterMenuSelectionNull":
					{
						empty = "Null";
						break;
					}
					case "FilterMenuSelectionNotNull":
					{
						empty = "Not Null";
						break;
					}
					case "FilterLogicalOperatorAnd":
					{
						empty = "AND";
						break;
					}
					case "FilterLogicalOperatorOr":
					{
						empty = "OR";
						break;
					}
					case "FilterCompositeNotOperator":
					{
						empty = "NOT";
						break;
					}
					case "DeleteRowMenuItem":
					{
						empty = "Eliminar Registro";
						break;
					}
					case "SortAscendingMenuItem":
					{
						empty = "Ordenar [A-Z]";
						break;
					}
					case "SortDescendingMenuItem":
					{
						empty = "Ordernar [Z-A]";
						break;
					}
					case "ClearSortingMenuItem":
					{
						empty = "Clear Sorting";
						break;
					}
					case "ConditionalFormattingMenuItem":
					{
						empty = "Conditional Formatting";
						break;
					}
					case "GroupByThisColumnMenuItem":
					{
						empty = "Agrupar por esta columna";
						break;
					}
					case "UngroupThisColumn":
					{
						empty = "Ungroup this column";
						break;
					}
					case "ColumnChooserMenuItem":
					{
						empty = "Column Chooser";
						break;
					}
					case "HideMenuItem":
					{
						empty = "Hide Column";
						break;
					}
					case "UnpinMenuItem":
					{
						empty = "Unpin Column";
						break;
					}
					case "UnpinRowMenuItem":
					{
						empty = "Unpin Row";
						break;
					}
					case "PinMenuItem":
					{
						empty = "Estado de Acoplamiento";
						break;
					}
					case "PinAtLeftMenuItem":
					{
						empty = "Fijar a la izquierda";
						break;
					}
					case "PinAtRightMenuItem":
					{
						empty = "Fijar a la derecha";
						break;
					}
					case "PinAtBottomMenuItem":
					{
						empty = "Fijar a inferior";
						break;
					}
					case "PinAtTopMenuItem":
					{
						empty = "Fijar en superior";
						break;
					}
					case "BestFitMenuItem":
					{
						empty = "Best Fit";
						break;
					}
					case "PasteMenuItem":
					{
						empty = "Pegar";
						break;
					}
					case "EditMenuItem":
					{
						empty = "Editar";
						break;
					}
					case "ClearValueMenuItem":
					{
						empty = "Limpiar Valor";
						break;
					}
					case "CopyMenuItem":
					{
						empty = "Copiar";
						break;
					}
					case "CutMenuItem":
					{
						empty = "Cortar";
						break;
					}
					case "AddNewRowString":
					{
						empty = "Haga click aqui para agregar un nuevo registro";
						break;
					}
					case "ConditionalFormattingCaption":
					{
						empty = "Conditional Formatting Rules Manager";
						break;
					}
					case "ConditionalFormattingLblColumn":
					{
						empty = "Format only cells with";
						break;
					}
					case "ConditionalFormattingLblName":
					{
						empty = "Rule name:";
						break;
					}
					case "ConditionalFormattingLblType":
					{
						empty = "Cell value:";
						break;
					}
					case "ConditionalFormattingLblValue1":
					{
						empty = "Value 1:";
						break;
					}
					case "ConditionalFormattingLblValue2":
					{
						empty = "Value 2:";
						break;
					}
					case "ConditionalFormattingGrpConditions":
					{
						empty = "Rules";
						break;
					}
					case "ConditionalFormattingGrpProperties":
					{
						empty = "Rule Properties";
						break;
					}
					case "ConditionalFormattingChkApplyToRow":
					{
						empty = "Apply this rule to entire row";
						break;
					}
					case "ConditionalFormattingBtnAdd":
					{
						empty = "Add new rule";
						break;
					}
					case "ConditionalFormattingBtnRemove":
					{
						empty = "Remove selected rule";
						break;
					}
					case "ConditionalFormattingBtnOK":
					{
						empty = "OK";
						break;
					}
					case "ConditionalFormattingBtnCancel":
					{
						empty = "Cancel";
						break;
					}
					case "ConditionalFormattingBtnApply":
					{
						empty = "Apply";
						break;
					}
					case "Rule applies on:":
					{
						empty = "Rule applies on:";
						break;
					}
					case "[Choose one]":
					{
						empty = "[Choose one]";
						break;
					}
					case "equals to [Value1]":
					{
						empty = "equals to [Value1]";
						break;
					}
					case "is not equal to [Value1]":
					{
						empty = "is not equal to [Value1]";
						break;
					}
					case "starts with [Value1]":
					{
						empty = "starts with [Value1]";
						break;
					}
					case "ends with [Value1]":
					{
						empty = "ends with [Value1]";
						break;
					}
					case "contains [Value1]":
					{
						empty = "contains [Value1]";
						break;
					}
					case "does not contain [Value1]":
					{
						empty = "does not contain [Value1]";
						break;
					}
					case "is greater than [Value1]":
					{
						empty = "is greater than [Value1]";
						break;
					}
					case "is greater than or equal [Value1]":
					{
						empty = "is greater than or equal [Value1]";
						break;
					}
					case "is less than [Value1]":
					{
						empty = "is less than [Value1]";
						break;
					}
					case "is less than or equal to [Value1]":
					{
						empty = "is less than or equal to [Value1]";
						break;
					}
					case "is between [Value1] and [Value2]":
					{
						empty = "is between [Value1] and [Value2]";
						break;
					}
					case "is not between [Value1] and [Value1]":
					{
						empty = "is not between [Value1] and [Value1]";
						break;
					}
					case "ColumnChooserFormCaption":
					{
						empty = "Column Chooser";
						break;
					}
					case "ColumnChooserFormMessage":
					{
						empty = "Drag a column header from the\ngrid here to remove it from\nthe current view.";
						break;
					}
					case "GroupingPanelDefaultMessage":
					{
						empty = "Arrastre la columna para efectuar la operacioin de Agrupación";
						break;
					}
					case "GroupingPanelHeader":
					{
						empty = "Agrupar por:";
						break;
					}
					case "NoDataText":
					{
						empty = "No data to display";
						break;
					}
					case "CompositeFilterFormErrorCaption":
					{
						empty = "Filter Error";
						break;
					}
					default:
					{
						empty = string.Empty;
						return empty;
					}
				}
			}
			else
			{
				empty = string.Empty;
				return empty;
			}
			return empty;
		}
	}
}