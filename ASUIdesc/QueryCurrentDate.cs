using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASUIdesc
{
    class QueryCurrentDate
    {
        private string quantityMonthPPR;
        private string normaVremMonthForPlan;
        private int indexForComboBox;
        private string curDate = DateTime.Now.ToString("MMM");


        public string getQuantityMonthPPRCurDate()
        {
            switch (curDate)
            {
                case "янв":
                    quantityMonthPPR = "quantity_plan_january";
                    normaVremMonthForPlan = "norma_vrem_plan_january";
                    indexForComboBox = 0;
                    break;
                case "фев":
                    quantityMonthPPR = "quantity_plan_february";
                    normaVremMonthForPlan = "norma_vrem_plan_february";
                    indexForComboBox = 1;
                    break;
                case "мар":
                    quantityMonthPPR = "quantity_plan_march";
                    normaVremMonthForPlan = "norma_vrem_plan_march";
                    indexForComboBox = 2;
                    break;
                case "апр":
                    quantityMonthPPR = "quantity_plan_april";
                    normaVremMonthForPlan = "norma_vrem_plan_april";
                    indexForComboBox = 3;
                    break;
                case "май":
                    quantityMonthPPR = "quantity_plan_may";
                    normaVremMonthForPlan = "norma_vrem_plan_may";
                    indexForComboBox = 4;
                    break;
                case "июн":
                    quantityMonthPPR = "quantity_plan_june";
                    normaVremMonthForPlan = "norma_vrem_plan_june";
                    indexForComboBox = 5;
                    break;
                case "июл":
                    quantityMonthPPR = "quantity_plan_july";
                    normaVremMonthForPlan = "norma_vrem_plan_july";
                    indexForComboBox = 6;
                    break;
                case "авг":
                    quantityMonthPPR = "quantity_plan_august";
                    normaVremMonthForPlan = "norma_vrem_plan_august";
                    indexForComboBox = 7;
                    break;
                case "сен":
                    quantityMonthPPR = "quantity_plan_september";
                    normaVremMonthForPlan = "norma_vrem_plan_september";
                    indexForComboBox = 8;
                    break;
                case "окт":
                    quantityMonthPPR = "quantity_plan_october";
                    normaVremMonthForPlan = "norma_vrem_plan_october";
                    indexForComboBox = 9;
                    break;
                case "ноя":
                    quantityMonthPPR = "quantity_plan_november";
                    normaVremMonthForPlan = "norma_vrem_plan_november";
                    indexForComboBox = 10;
                    break;
                case "дек":
                    quantityMonthPPR = "quantity_plan_december";
                    normaVremMonthForPlan = "norma_vrem_plan_december";
                    indexForComboBox = 11;
                    break;
            }
            return quantityMonthPPR;
        }

        public string getNormaVremMonthForPlan()
        {
            return normaVremMonthForPlan;
        }
        public int IndexMonth()
        {
            return indexForComboBox;
        }
    }
}
