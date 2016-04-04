using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        /// <summary>
        /// Hold a list of current gardens
        /// </summary>
        private List<Garden> gardenList;

        /// <summary>
        /// Delegate for report type
        /// </summary>
        /// <param name="garden">Garden to process</param>
        /// <returns>String from Garden report</returns>
        private delegate String Report(Garden garden);

        /// <summary>
        /// Constructor
        /// </summary>
        public GardenManager()
        {
            //Create new list of gardens
            gardenList = new List<Garden>();
        }

        /// <summary>
        /// Add a new garden to the manager
        /// </summary>
        /// <param name="garden">Garden to add</param>
        public void AddGarden(Garden garden)
        {
            gardenList.Add(garden);
        }

        /// <summary>
        /// Create a report using the given delegate
        /// </summary>
        /// <param name="report">Report type</param>
        /// <returns>String list of report</returns>
        private List<String> ProcessGardens(Report report)
        {
            //Hold the report ready to return
            List<String> output = new List<String>();

            foreach (Garden g in gardenList)
            {
                output.Add(report(g));
            }
            return output;
        }

        /// <summary>
        /// Does area report for one garden
        /// </summary>
        /// <param name="garden">Garden to do report for</param>
        /// <returns>Gardens report</returns>
        private String areaReportItem(Garden garden)
        {
            //Get area
            double area = garden.GetArea();

            //Get owner name
            String ownerName = garden.OwnerName;
            //Build report string
            String output = String.Format("{0,-14}:{1,8:f2}", ownerName, area);

            return output;
        }

        /// <summary>
        /// Does charges report for one garden
        /// </summary>
        /// <param name="garden">Garden to do report for</param>
        /// <returns>gardens report</returns>
        private String chargesReportItem(Garden garden)
        {
            //Get charges
            double charges = garden.GetAccountBalance();

            //Get owner name
            String ownerName = garden.OwnerName;
            //Build report string
            String output = String.Format("{0,-14}:${1,8:f2}", ownerName, charges);

            return output;
        }

        public List<String> GetAreaReport()
        {
            Report reportType = new Report(areaReportItem);
            return ProcessGardens(reportType);
        }

        public List<String> GetChargesReport()
        {
            Report reportType = new Report(chargesReportItem);
            return ProcessGardens(reportType);
        }
    }
}
