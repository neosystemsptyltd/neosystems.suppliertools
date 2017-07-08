/*
                    GNU LESSER GENERAL PUBLIC LICENSE
                       Version 3, 29 June 2007

 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.


  This version of the GNU Lesser General Public License incorporates
the terms and conditions of version 3 of the GNU General Public
License, supplemented by the additional permissions listed below.

  0. Additional Definitions.

  As used herein, "this License" refers to version 3 of the GNU Lesser
General Public License, and the "GNU GPL" refers to version 3 of the GNU
General Public License.

  "The Library" refers to a covered work governed by this License,
other than an Application or a Combined Work as defined below.

  An "Application" is any work that makes use of an interface provided
by the Library, but which is not otherwise based on the Library.
Defining a subclass of a class defined by the Library is deemed a mode
of using an interface provided by the Library.

  A "Combined Work" is a work produced by combining or linking an
Application with the Library.  The particular version of the Library
with which the Combined Work was made is also called the "Linked
Version".

  The "Minimal Corresponding Source" for a Combined Work means the
Corresponding Source for the Combined Work, excluding any source code
for portions of the Combined Work that, considered in isolation, are
based on the Application, and not on the Linked Version.

  The "Corresponding Application Code" for a Combined Work means the
object code and/or source code for the Application, including any data
and utility programs needed for reproducing the Combined Work from the
Application, but excluding the System Libraries of the Combined Work.

  1. Exception to Section 3 of the GNU GPL.

  You may convey a covered work under sections 3 and 4 of this License
without being bound by section 3 of the GNU GPL.

  2. Conveying Modified Versions.

  If you modify a copy of the Library, and, in your modifications, a
facility refers to a function or data to be supplied by an Application
that uses the facility (other than as an argument passed when the
facility is invoked), then you may convey a copy of the modified
version:

   a) under this License, provided that you make a good faith effort to
   ensure that, in the event an Application does not supply the
   function or data, the facility still operates, and performs
   whatever part of its purpose remains meaningful, or

   b) under the GNU GPL, with none of the additional permissions of
   this License applicable to that copy.

  3. Object Code Incorporating Material from Library Header Files.

  The object code form of an Application may incorporate material from
a header file that is part of the Library.  You may convey such object
code under terms of your choice, provided that, if the incorporated
material is not limited to numerical parameters, data structure
layouts and accessors, or small macros, inline functions and templates
(ten or fewer lines in length), you do both of the following:

   a) Give prominent notice with each copy of the object code that the
   Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the object code with a copy of the GNU GPL and this license
   document.

  4. Combined Works.

  You may convey a Combined Work under terms of your choice that,
taken together, effectively do not restrict modification of the
portions of the Library contained in the Combined Work and reverse
engineering for debugging such modifications, if you also do each of
the following:

   a) Give prominent notice with each copy of the Combined Work that
   the Library is used in it and that the Library and its use are
   covered by this License.

   b) Accompany the Combined Work with a copy of the GNU GPL and this license
   document.

   c) For a Combined Work that displays copyright notices during
   execution, include the copyright notice for the Library among
   these notices, as well as a reference directing the user to the
   copies of the GNU GPL and this license document.

   d) Do one of the following:

       0) Convey the Minimal Corresponding Source under the terms of this
       License, and the Corresponding Application Code in a form
       suitable for, and under terms that permit, the user to
       recombine or relink the Application with a modified version of
       the Linked Version to produce a modified Combined Work, in the
       manner specified by section 6 of the GNU GPL for conveying
       Corresponding Source.

       1) Use a suitable shared library mechanism for linking with the
       Library.  A suitable mechanism is one that (a) uses at run time
       a copy of the Library already present on the user's computer
       system, and (b) will operate properly with a modified version
       of the Library that is interface-compatible with the Linked
       Version.

   e) Provide Installation Information, but only if you would otherwise
   be required to provide such information under section 6 of the
   GNU GPL, and only to the extent that such information is
   necessary to install and execute a modified version of the
   Combined Work produced by recombining or relinking the
   Application with a modified version of the Linked Version. (If
   you use option 4d0, the Installation Information must accompany
   the Minimal Corresponding Source and Corresponding Application
   Code. If you use option 4d1, you must provide the Installation
   Information in the manner specified by section 6 of the GNU GPL
   for conveying Corresponding Source.)

  5. Combined Libraries.

  You may place library facilities that are a work based on the
Library side by side in a single library together with other library
facilities that are not Applications and are not covered by this
License, and convey such a combined library under terms of your
choice, if you do both of the following:

   a) Accompany the combined library with a copy of the same work based
   on the Library, uncombined with any other library facilities,
   conveyed under the terms of this License.

   b) Give prominent notice with the combined library that part of it
   is a work based on the Library, and explaining where to find the
   accompanying uncombined form of the same work.

  6. Revised Versions of the GNU Lesser General Public License.

  The Free Software Foundation may publish revised and/or new versions
of the GNU Lesser General Public License from time to time. Such new
versions will be similar in spirit to the present version, but may
differ in detail to address new problems or concerns.

  Each version is given a distinguishing version number. If the
Library as you received it specifies that a certain numbered version
of the GNU Lesser General Public License "or any later version"
applies to it, you have the option of following the terms and
conditions either of that published version or of any later version
published by the Free Software Foundation. If the Library as you
received it does not specify a version number of the GNU Lesser
General Public License, you may choose any version of the GNU Lesser
General Public License ever published by the Free Software Foundation.

  If the Library as you received it specifies that a proxy can decide
whether future versions of the GNU Lesser General Public License shall
apply, that proxy's public statement of acceptance of any version is
permanent authorization for you to choose that version for the
Library.

 */

using NeoSystems.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace NeoSystems.SupplierTools
{
    /// <summary>
    /// Mouser website webtools
    /// NOTE: mouser generic search url :
    /// was: http://www.mouser.com/_/N-scv7?Keyword=
    /// now: http://www.mouser.co.za/search/ProductDetail.aspx?R=
    /// </summary>
    public class MouserWebtools : SupplierWebToolsBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MouserWebtools()
        {
        }

        /// <summary>
        /// Build the URL string
        /// </summary>
        /// <param name="pn"></param>
        public override void BuildUrl(string pn)
        {
            string temp = HttpUtility.UrlEncode(pn);

            // changed to accommodate parts not in stock
            Url = @"http://www.mouser.co.za/search/ProductDetail.aspx?R=" + temp;
        }

        /// <summary>
        /// Gte manufacturer from Mouser website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturer()
        {
            try
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(WebPageData);

                HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode(@"//body//span[@itemprop='name']");

                if (node != null)
                {
                    return node.InnerText.Trim();
                }
                else
                {
                    return "<UNKNOWN>";
                }
                /*
                for (int i = 0; i < WebPageLines.Count(); i++)
                {
                    string s = WebPageLines[i];
                    if (s.Contains("Manufacturer:</b>"))
                    {
                        string temp = WebPageLines[i + 4].Trim();
                        return StringUtils.GetTextBetweenMarkers(temp, @""">", @"</a>");
                    }
                }
                return "";*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Manufcaturer partnumber from the mouser website
        /// </summary>
        /// <returns></returns>
        public override string GetManufacturerPartNo()
        {
            try
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(WebPageData);

                HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode(@"//body//div[@id='divManufacturerPartNum']//h1");

                if (node != null)
                {
                    return node.InnerText.Trim();
                }
                else
                {
                    return "<UNKNOWN>";
                }

                /*
                string res = "";
                for (int i = 0; i < WebPageLines.Count(); i++)
                {
                    string s = WebPageLines[i];
                    if (s.Contains("Manufacturer Part #:</b>"))
                    {
                        res = WebPageLines[i + 5];
                        res = res.Replace("</h1>", "");
                        return res.Trim();
                    }
                }
                return res;*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Return pricing info from the mouser website
        /// </summary>
        /// <returns></returns>
        public override PricingInfo[] GetPricingInfo()
        {
            try
            {
                List<PricingInfo> priceslist = new List<PricingInfo>(50);
                bool Done = false;

                HtmlDocument htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(WebPageData);

                for(int i=1; (i<1000) && (!Done); i++)
                {
                    string qstr = string.Format("ctl00_ContentMain_ucP_rptrPriceBreaks_ctl0{0}_lnkQuantity", i);
                    string pstr = string.Format("ctl00_ContentMain_ucP_rptrPriceBreaks_ctl0{0}_lblPrice", i);

                    HtmlNode nodeqty = htmlDoc.GetElementbyId(qstr);
                    HtmlNode nodeprice = htmlDoc.GetElementbyId(pstr);

                    if ((nodeprice != null) && (nodeprice != null))
                    {
                        string qtystr = nodeqty.InnerText.Replace(",", ""); // AJTODO correctly parse thousands separator
                        string pricestr = nodeprice.InnerText.Replace("$", ""); // AJTODO write a generic currency parser - or use an existing one

                        if ((qtystr != "") && (pricestr != ""))
                        {
                            int min = Int32.Parse(qtystr);
                            if (!pricestr.Contains("Quote"))
                            {
                                double srcunitprice = double.Parse(pricestr);
                                double destprice = Currency.Convert("USD", DefDestCurrency, srcunitprice);

                                PricingInfo p = new PricingInfo("USD", DefDestCurrency, srcunitprice, destprice, min, 999999);
                                priceslist.Add(p);
                            }
                        }

                    }
                    else
                    {
                        Done = true;
                    }
                }

                FixMaximumQtys(ref priceslist);

                return priceslist.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            /*
             * 
                        int i = 0;
                        int state = 0;
                        int qty = 0;
                        double price;
                        List<PricingInfo> priceslist = new List<PricingInfo>(50);

                        try
                        {
                            while ((i < WebPageLines.Count()) && (state < 2))
                            {
                                switch (state)
                                {
                                    case 0:
                                        if (WebPageLines[i].Contains(@"<table class=""PriceBreaks"" cellspacing=""0"">"))
                                        {
                                            state = 1;
                                            i += 11;
                                        }
                                        else
                                        {
                                            i++;
                                        }
                                        break;

                                    case 1:
                                        string res = StringUtils.GetTextBetweenMarkers(WebPageLines[i], @""">", "</a>");
                                        res = StringUtils.StringToNumericsOnly(res);
                                        if (!Int32.TryParse(res, out qty))
                                        {
                                            throw new Exception("Invalid qty in mouser webpage.");
                                        }

                                        string pricestr;
                                        if (!WebPageLines[i + 3].Contains(@"Quote</></span>"))
                                        {
                                            pricestr = StringUtils.GetTextBetweenMarkers(WebPageLines[i + 3], @""">$", "</span>");
                                            if (!Double.TryParse(pricestr, out price))
                                            {
                                                throw new Exception("Invalid price in mouser webpage.");
                                            }
                                            double destprice = Currency.Convert("USD", "ZAR", price);
                                            PricingInfo p = new PricingInfo("USD", "ZAR", price, destprice, qty, 9999999);
                                            priceslist.Add(p);

                                        }
                                        if ((WebPageLines[i + 16] == "<tr>") &&
                                            (!WebPageLines[i + 3].Contains(@"Quote</></span>")))
                                        {
                                            i += 19;
                                        }
                                        else
                                        {
                                            state = 2;
                                        }
                                        break;

                                    default:
                                        break;
                                }
                            }

                            // fix the maximum values
                            for (i = 0; i < (priceslist.Count() - 1); i++)
                            {
                                PricingInfo tp = priceslist[i];
                                tp.maxqty = priceslist[i + 1].minqty - 1;
                                priceslist[i] = tp;
                            }

                            return priceslist.ToArray();
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
            */

        }
    }

}
