using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;
using Stimulsoft.Report.Dictionary;
using System.Drawing;

namespace SSManager
{
    public static class ReportHelper
    {
        static TimeSpan ExportTime;


        public static Exception ExportToExcel(ref DataTable dt, string OutputPath, bool HasPageHeader = true, bool HasHeaderBand = true,
                                                bool HasFooter = true, bool HasLineNo = false)
        {
            try
            {
                DateTime ExportTimeStart = DateTime.Now;
                StiReport report = new StiReport();
                StiPage page = report.Pages[0];
                page.PaperSize = System.Drawing.Printing.PaperKind.Custom;
                page.PageWidth = dt.Columns.Count * 1.2;
                StiHeaderBand headerBand = new StiHeaderBand();
                StiText headerText = new StiText(new RectangleD(0, 0, page.Width, 0.5));
                page.RightToLeft = true;
                dt.TableName = "Result";

                if (HasPageHeader)
                    AddPageHeader(ref page, ref headerText);

                if (HasFooter)
                    AddFooter(ref page);

                HasHeaderBand = false;
                if (HasHeaderBand)
                    AddHasHeaderBand(ref headerText, ref page, ref headerBand);

                #region Data
                //Create Databand
                StiDataBand dataBand = new StiDataBand();
                dataBand.DataSourceName = "Result";
                dataBand.Height = 0.5;
                dataBand.CanGrow = true;
                dataBand.GrowToHeight = true;
                headerText.HorAlignment = StiTextHorAlignment.Right;
                dataBand.Name = "DataBand1";
                page.Components.Add(dataBand);

                #endregion data

                double pos = 0;
                double columnWidth = (page.Width - 1) / dt.Columns.Count;
                int nameIndex = 1;
                // StiDataTableSource userSource = new StiDataTableSource("Result", "Result", "Result");

                StiText hText = new StiText();
                StiText dataText = new StiText();

                
                #region FillHeaderAndDate
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    //userSource.Columns.Add(new Stimulsoft.Report.Dictionary.StiDataColumn(dataColumn.ColumnName, dataColumn.GetType()));

                    //Create text on header
                    //  StiText 
                    hText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5));
                    hText.HorAlignment = StiTextHorAlignment.Center;
                    hText.VertAlignment = StiVertAlignment.Center;
                    hText.Font = new System.Drawing.Font("Tahoma", 10);
                    hText.Brush = new StiSolidBrush(Color.LightSteelBlue);
                    hText.Interaction.SortingEnabled = true;
                    hText.Interaction.SortingColumn = "DataBand." + Stimulsoft.Report.CodeDom.StiCodeDomSerializator.ReplaceSymbols(dataColumn.ColumnName);
                    hText.Text.Value = dataColumn.Caption;
                    hText.Name = "HeaderText" + nameIndex.ToString();
                    hText.WordWrap = true;
                    hText.CanGrow = true;
                    hText.GrowToHeight = true;
                    hText.Border.Side = StiBorderSides.All;
                    headerBand.Components.Add(hText);

                    //StiText 
                    dataText = new StiText(new RectangleD(pos, 0, columnWidth, 0.5));
                    dataText.HorAlignment = StiTextHorAlignment.Center;
                    dataText.VertAlignment = StiVertAlignment.Center;
                    dataText.Font = new System.Drawing.Font("Tahoma", 10);
                    dataText.Text = "{Result." + Stimulsoft.Report.CodeDom.StiCodeDomSerializator.ReplaceSymbols(dataColumn.ColumnName) + "}";
                    dataText.Name = "DataText" + nameIndex.ToString();
                    dataText.WordWrap = true;
                    dataText.CanGrow = true;
                    dataText.GrowToHeight = true;
                    dataText.ShrinkFontToFit = true;
                    dataText.Border.Side = StiBorderSides.All;
                    dataText.Interaction.SortingEnabled = true;
                    dataBand.Components.Add(dataText);
                    pos = pos + columnWidth;
                    nameIndex++;
                }
                #endregion
                
                if (HasLineNo)
                    AddLineNo(ref hText, ref dataText, ref headerBand, ref dataBand);
                string rptPath = System.IO.Path.GetTempFileName();
                report.RegData("Result", dt);
                //report.Save(rptPath);
                //report.Load(rptPath);
                //report.RegData("Result", dt);
                report.Design();
                //userSource.SetData()
                //userSource.Dictionary = 
                
                
                //report.CacheAllData = true;
                report.Render(true);

                StiExcel2007ExportService excelExport = new StiExcel2007ExportService();
                //StiExcelExportService excelExport = new StiExcelExportService();
                excelExport.ExportExcel(report, OutputPath);


                DateTime ExportTimeEnd = DateTime.Now;
                ExportTime = (ExportTimeEnd - ExportTimeStart);

                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        private static void AddHasHeaderBand(ref StiText headerText, ref StiPage page, ref StiHeaderBand headerBand)
        {
            //Create HeaderBand            
            headerBand.Height = 0.5;
            headerBand.CanGrow = true;
            headerBand.CanShrink = true;
            headerText.HorAlignment = StiTextHorAlignment.Right;
            headerBand.Name = "HeaderBand";
            page.Components.Add(headerBand);
        }

        private static void AddFooter(ref StiPage page)
        {
            #region Footer

            //Create FooterBand
            StiPageFooterBand FooterBand = new StiPageFooterBand();
            FooterBand.Height = 0.5;
            FooterBand.Name = "FooterBandBand";
            FooterBand.Enabled = true;
            page.Components.Add(FooterBand);

            ////Create countText text on Footer
            //StiText countText = new StiText(new RectangleD(0, 0, page.Width, 0.85));
            //countText.Text = dataSet.Tables[0].Rows.Count.ToString();
            //countText.HorAlignment = StiTextHorAlignment.Right;
            //countText.Name = "countText";
            //FooterBand.Components.Add(countText);

            #endregion Footer
        }

        private static void AddPageHeader(ref StiPage page, ref StiText headerText)
        {
            #region Header
            //Create TitleBand
            StiPageHeaderBand pageHeaderBand = new StiPageHeaderBand();
            pageHeaderBand.Height = 0.5;
            pageHeaderBand.Name = "pageHeaderBand";
            pageHeaderBand.Enabled = true;
            page.Components.Add(pageHeaderBand);

            //Create Title text on header
            headerText.Text = DateTime.Now.ToString(); // Common.Date.GetGregorianDate(currentDateTime, Common.Date.DateStringType.Short);
            headerText.Height = 0.5;
            headerText.HorAlignment = StiTextHorAlignment.Right;
            headerText.Name = "TitleHeader";
            //headerText.Font = new System.Drawing.Font("Nazanin", 12F);
            pageHeaderBand.Components.Add(headerText);

            // Create Title text on header
            StiText pageNumberText = new StiText(new RectangleD(0, 0, page.Width, 0.5));
            headerText.Height = 0.5;
            pageNumberText.Text = "{PageNumber}" + "-" + "{TotalPageCount}";
            pageNumberText.HorAlignment = StiTextHorAlignment.Left;
            pageNumberText.Name = "pageNumberText";
            //headerText.Font = new System.Drawing.Font("Nazanin", 12F);
            pageHeaderBand.Components.Add(pageNumberText);

            #endregion
        }
        private static void AddLineNo(ref StiText hText, ref StiText dataText, ref StiHeaderBand headerBand, ref StiDataBand dataBand)
        {
            double pos = 0;
            int nameIndex = 1;
            #region line
            //Create text on header
            hText = new StiText(new RectangleD(pos, 0, 1, 0.5));
            hText.Text.Value = "ردیف";
            hText.HorAlignment = StiTextHorAlignment.Center;
            hText.VertAlignment = StiVertAlignment.Center;
            hText.Font = new System.Drawing.Font("Tahoma", 10);
            hText.Brush = new StiSolidBrush(Color.LightBlue);
            hText.Name = "LineText" + nameIndex.ToString();
            hText.WordWrap = true;
            hText.CanGrow = true;
            hText.GrowToHeight = true;
            hText.Border.Side = StiBorderSides.All;
            headerBand.Components.Add(hText);

            dataText = new StiText(new RectangleD(pos, 0, 1, 0.5));
            dataText.HorAlignment = StiTextHorAlignment.Center;
            dataText.VertAlignment = StiVertAlignment.Center;
            dataText.Font = new System.Drawing.Font("Tahoma", 10);
            dataText.Text = "{Line}";
            dataText.WordWrap = true;
            dataText.CanGrow = true;
            dataText.GrowToHeight = true;
            dataText.Border.Side = StiBorderSides.All;
            dataText.Interaction.SortingEnabled = true;
            dataBand.Components.Add(dataText);

            #endregion line
        }

    }
}
