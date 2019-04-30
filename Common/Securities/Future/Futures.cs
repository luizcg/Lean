﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace QuantConnect.Securities
{
    /// <summary>
    /// Futures static class contains shortcut definitions of major futures contracts available for trading
    /// </summary>
    public static class Futures
    {
        /// <summary>
        /// Grains and Oilseeds group 
        /// </summary>
        public static class Grains
        {
            /// <summary>
            /// Black Sea Corn Financially Settled (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string BlackSeaCornFinanciallySettledPlatts = "BCF";

            /// <summary>
            /// Wheat Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Wheat = "ZW";

            /// <summary>
            /// Corn Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Corn = "ZC";

            /// <summary>
            /// Soybeans Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Soybeans = "ZS";

            /// <summary>
            /// Soybean Meal Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SoybeanMeal = "ZM";

            /// <summary>
            /// Soybean Oil Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SoybeanOil = "ZL";

            /// <summary>
            /// Oats Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Oats = "ZO";
        }

        /// <summary>
        /// Currencies group
        /// </summary>
        public static class Currencies
        {
            /// <summary>
            /// U.S. Dollar Index Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string USD = "DX";

            /// <summary>
            /// British Pound Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GBP = "6B";

            /// <summary>
            /// Canadian Dollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string CAD = "6C";

            /// <summary>
            /// Japanese Yen Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string JPY = "6J";

            /// <summary>
            /// Swiss Franc Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string CHF = "6S";

            /// <summary>
            /// Euro FX Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EUR = "6E";

            /// <summary>
            /// Australian Dollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string AUD = "6A";

            /// <summary>
            /// New Zealand Dollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string NZD = "6N";
    
            /// <summary>
            /// Russian Ruble Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string RUB = "6R";

            /// <summary>
            /// Brazillian Real Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string BRL = "6L";

            /// <summary>
            /// Mexican Peso Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MXN = "6M";

            /// <summary>
            /// South African Rand Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ZAR = "6Z";
            
            /// <summary>
            /// Australian Dollar/Canadian Dollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string AUDCAD = "ACD";
            
            /// <summary>
            /// Australian Dollar/Japanese Yen Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string AUDJPY = "AJY";
            
            /// <summary>
            /// Australian Dollar/New Zealand Dollar Futures
            /// </summary>
            public const string AUDNZD = "ANE";
        }

        /// <summary>
        /// Energies group
        /// </summary>
        public static class Energies
        {
            /// <summary>
            /// Propane Non LDH Mont Belvieu (OPIS) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string PropaneNonLDHMontBelvieu = "1S";

            /// <summary>
            /// Argus Propane Far East Index BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ArgusPropaneFarEastIndexBALMO = "22";

            /// <summary>
            /// Mini European 3.5% Fuel Oil Barges FOB Rdam (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MiniEuropeanThreePointPercentFiveFuelOilBargesPlatts = "A0D";
            
            /// <summary>
            /// Mini Singapore Fuel Oil 180 cst (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MiniSingaporeFuelOil180CstPlatts = "A0F";
            
            /// <summary>
            /// Gulf Coast ULSD (Platts) Up-Down BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GulfCoastULSDPlattsUpDownBALMO = "A1L";
            
            /// <summary>
            /// Gulf Coast Jet (Platts) Up-Down BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GulfCoastJetPlattsUpDownBALMO = "A1M";

            /// <summary>
            /// Propane Non-LDH Mont Belvieu (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string PropaneNonLDHMontBelvieuOPIS = "A1R";

            /// <summary>
            /// European Propane CIF ARA (Argus) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EuropeanPropaneCIFARAArgusBALMO = "A32";
            
            /// <summary>
            /// Premium Unleaded Gasoline 10 ppm FOB MED (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string PremiumUnleadedGasoline10ppmFOBMEDPlatts = "A3G";
            
            /// <summary>
            /// Argus Propane Far East Index Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ArgusPropaneFarEastIndex = "A7E";

            /// <summary>
            /// Gasoline Euro-bob Oxy NWE Barges (Argus) Crack Spread BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GasolineEurobobOxyNWEBargesArgusCrackSpreadBALMO = "A7I";

            /// <summary>
            /// Mont Belvieu Natural Gasoline (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuNaturalGasolineOPIS = "A7Q";

            /// <summary>
            /// Mont Belvieu Normal Butane (OPIS) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuNormalButaneOPISBALMO = "A8J";
            
            /// <summary>
            /// Conway Propane (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ConwayPropaneOPIS = "A8K";

            /// <summary>
            /// Mont Belvieu LDH Propane (OPIS) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuLDHPropaneOPISBALMO = "A8O";
            
            /// <summary>
            /// Argus Propane Far East Index vs. European Propane CIF ARA (Argus) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ArgusPropaneFarEastIndexVsEuropeanPropaneCIFARAArgus = "A91";

            /// <summary>
            /// Argus Propane (Saudi Aramco) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ArgusPropaneSaudiAramco = "A9N";

            /// <summary>
            /// Group Three ULSD (Platts) vs. NY Harbor ULSD Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GroupThreeULSDPlattsVsNYHarborULSD = "AA6";
            
            /// <summary>
            /// Group Three Sub-octane Gasoliine (Platts) vs. RBOB Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GroupThreeSuboctaneGasolinePlattsVsRBOB = "AA8";
            
            /// <summary>
            /// Singapore Fuel Oil 180 cst (Platts) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SingaporeFuelOil180cstPlattsBALMO = "ABS";
        
            /// <summary>
            /// Singapore Fuel Oil 380 cst (Platts) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SingaporeFuelOil380cstPlattsBALMO = "ABT";
            
            /// <summary>
            /// Mont Belvieu Ethane (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuEthaneOPIS = "AC0";
            
            /// <summary>
            /// Mont Belvieu Normal Butane (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuNormalButaneOPIS = "AD0";
            
            /// <summary>
            /// Brent Crude Oil vs. Dubai Crude Oil (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string BrentCrudeOilVsDubaiCrudeOilPlatts = "ADB";
            
            /// <summary>
            /// Argus LLS vs. WTI (Argus) Trade Month Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ArgusLLSvsWTIArgusTradeMonth = "AE5";
            
            /// <summary>
            /// Singapore Gasoil (Platts) vs. Low Sulphur Gasoil Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SingaporeGasoilPlattsVsLowSulphurGasoilFutures = "AGA";

            /// <summary>
            /// Los Angeles CARBOB Gasoline (OPIS) vs. RBOB Gasoline Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string LosAngelesCARBOBGasolineOPISvsRBOBGasoline = "AJL";

            /// <summary>
            /// Los Angeles Jet (OPIS) vs. NY Harbor ULSD Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string LosAngelesJetOPISvsNYHarborULSD = "AJS";

            /// <summary>
            /// Los Angeles CARB Diesel (OPIS) vs. NY Harbor ULSD Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string LosAngelesCARBDieselOPISvsNYHarborULSD = "AKL";

            /// <summary>
            /// European Naphtha (Platts) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EuropeanNaphthaPlattsBALMO = "AKZ";
            
            /// <summary>
            /// European Propane CIF ARA (Argus) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EuropeanPropaneCIFARAArgus = "APS";
            
            /// <summary>
            /// Mont Belvieu Natural Gasoline (OPIS) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuNaturalGasolineOPISBALMO = "AR0";
            
            /// <summary>
            /// RBOB Gasoline Crack Spread Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string RBOBGasolineCrackSpread = "ARE";
            
            /// <summary>
            /// Gulf Coast HSFO (Platts) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GulfCoastHSFOPlattsBALMO = "AVZ";
            
            /// <summary>
            /// Mars (Argus) vs. WTI Trade Month Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MarsArgusVsWTITradeMonth = "AYV";

            /// <summary>
            /// Mars (Argus) vs. WTI Financial Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MarsArgusVsWTIFinancial = "AYX";

            /// <summary>
            /// Ethanol T2 FOB Rdam Including Duty (Platts) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EthanolT2FOBRdamIncludingDutyPlatts = "AZ1";

            /// <summary>
            /// Mont Belvieu LDH Propane (OPIS) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string MontBelvieuLDHPropaneOPIS = "B0";

            /// <summary>
            /// Gasoline Euro-bob Oxy NWE Barges (Argus) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GasolineEurobobOxyNWEBargesArgus = "B7H";
            
            /// <summary>
            /// WTI-Brent Financial Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string WTIBrentFinancial = "BK";

            /// <summary>
            /// 3.5% Fuel Oil Barges FOB Rdam (Platts) Crack Spread (1000mt) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string ThreePointFivePercentFuelOilBargesFOBRdamPlattsCrackSpread1000mt = "BOO";

            /// <summary>
            /// Gasoline Euro-bob Oxy NWE Barges (Argus) BALMO Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string GasolineEurobobOxyNWEBargesArgusBALMO = "BR7";

            /// <summary>
            /// Crude Oil WTI Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string CrudeOilWTI = "CL";

            /// <summary>
            /// Heating Oil Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string HeatingOil = "HO";

            /// <summary>
            /// Gasoline RBOB Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Gasoline = "RB";

            /// <summary>
            /// Natural Gas Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string NaturalGas = "NG";
        }

        /// <summary>
        /// Financials group
        /// </summary>
        public static class Financials
        {
            /// <summary>
            /// 30Y U.S. Treasury Bond Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Y30TreasuryBond = "ZB";

            /// <summary>
            /// 10Y U.S. Treasury Note Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Y10TreasuryNote = "ZN";

            /// <summary>
            /// 5Y U.S. Treasury Note Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Y5TreasuryNote = "ZF";

            /// <summary>
            /// 2Y U.S. Treasury Note Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Y2TreasuryNote = "ZT";

            /// <summary>
            /// EuroDollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string EuroDollar = "GE";
        }

        /// <summary>
        /// Indices group
        /// </summary>
        public static class Indices
        {
            /// <summary>
            /// E-mini S&amp;P 500 Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string SP500EMini = "ES";

            /// <summary>
            /// E-mini NASDAQ 100 Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string NASDAQ100EMini = "NQ";

            /// <summary>
            /// E-mini Dow Indu 30 Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Dow30EMini = "YM";

            /// <summary>
            /// CBOE Volatility Index Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string VIX = "VX";

            /// <summary>
            /// E-mini Russell 2000 Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Russell2000EMini = "RTY";

            /// <summary>
            /// Nikkei-225 Dollar Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Nikkei225Dollar = "NKD";
            
            /// <summary>
            /// Bloomberg Commodity Index Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string BloombergCommodityIndex = "AW";

            /// <summary>
            /// E-mini Nasdaq-100 Biotechnology Index Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string NASDAQ100BiotechnologyEMini = "BIO";
        }

        /// <summary>
        /// Meats group
        /// </summary>
        public static class Meats
        {
            /// <summary>
            /// Live Cattle Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string LiveCattle = "LE";

            /// <summary>
            /// Feeder Cattle Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string FeederCattle = "GF";

            /// <summary>
            /// Lean Hogs Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string LeanHogs = "HE";
        }

        /// <summary>
        /// Metals group
        /// </summary>
        public static class Metals
        {
            /// <summary>
            /// Gold Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Gold = "GC";

            /// <summary>
            /// Silver Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Silver = "SI";

            /// <summary>
            /// Platinum Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Platinum = "PL";

            /// <summary>
            /// Palladium Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Palladium = "PA";

            /// <summary>
            /// Aluminum MW U.S. Transaction Premium Platts (25MT) Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string AluminumMWUSTransactionPremiumPlatts25MT = "AUP";
        }

        /// <summary>
        /// Softs group
        /// </summary>
        public static class Softs
        {
            /// <summary>
            /// Cotton #2 Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Cotton2 = "CT";

            /// <summary>
            /// Orange Juice Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string OrangeJuice = "OJ";

            /// <summary>
            /// Coffee C Arabica Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Coffee = "KC";

            /// <summary>
            /// Sugar #11 Futures ICE
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Sugar11 = "SB";

            /// <summary>
            /// Sugar #11 Futures CME
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Sugar11CME = "YO";

            /// <summary>
            /// Cocoa Futures
            /// </summary>
            /// <returns>The symbol</returns>
            public const string Cocoa = "CC";
        }
    }
}