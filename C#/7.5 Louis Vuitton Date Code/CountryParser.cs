using System;

namespace LouVuiDateCode
{
    public static class CountryParser
    {
        /// <summary>
        /// Gets a an array of <see cref="Country"/> enumeration values for a specified factory location code. One location code can belong to many countries.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <returns>An array of <see cref="Country"/> enumeration values.</returns>
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            return factoryLocationCode switch
            {
                "A0" => new Country[] { Country.France },
                "A1" => new Country[] { Country.France },
                "A2" => new Country[] { Country.France },
                "AA" => new Country[] { Country.France },
                "AAS" => new Country[] { Country.France },
                "AH" => new Country[] { Country.France },
                "AN" => new Country[] { Country.France },
                "AR" => new Country[] { Country.France },
                "AS" => new Country[] { Country.France },
                "BA" => new Country[] { Country.France },
                "BC" => new Country[] { Country.Italy, Country.Spain },
                "BJ" => new Country[] { Country.France },
                "BO" => new Country[] { Country.Italy },
                "BU" => new Country[] { Country.France },
                "DI" => new Country[] { Country.Switzerland },
                "DR" => new Country[] { Country.France },
                "DU" => new Country[] { Country.France },
                "DT" => new Country[] { Country.France },
                "CA" => new Country[] { Country.Spain },
                "CE" => new Country[] { Country.Italy },
                "CO" => new Country[] { Country.France },
                "CT" => new Country[] { Country.France },
                "CX" => new Country[] { Country.France },
                "ET" => new Country[] { Country.France },
                "FA" => new Country[] { Country.Switzerland, Country.USA },
                "FC" => new Country[] { Country.USA },
                "FH" => new Country[] { Country.USA },
                "FO" => new Country[] { Country.Italy },
                "FL" => new Country[] { Country.France, Country.USA },
                "FN" => new Country[] { Country.Italy },
                "GI" => new Country[] { Country.Spain },
                "LA" => new Country[] { Country.France, Country.USA },
                "LB" => new Country[] { Country.Spain },
                "LM" => new Country[] { Country.Spain },
                "LO" => new Country[] { Country.Spain },
                "LP" => new Country[] { Country.Germany },
                "LW" => new Country[] { Country.France, Country.Spain },
                "MA" => new Country[] { Country.Italy },
                "MB" => new Country[] { Country.France },
                "MI" => new Country[] { Country.France },
                "NO" => new Country[] { Country.France },
                "NZ" => new Country[] { Country.Italy },
                "OB" => new Country[] { Country.Italy },
                "OL" => new Country[] { Country.Germany },
                "OS" => new Country[] { Country.USA },
                "PL" => new Country[] { Country.Italy },
                "RA" => new Country[] { Country.France },
                "RC" => new Country[] { Country.Italy },
                "RE" => new Country[] { Country.Italy },
                "RI" => new Country[] { Country.France },
                "SA" => new Country[] { Country.France, Country.Italy },
                "SD" => new Country[] { Country.France, Country.USA },
                "SF" => new Country[] { Country.France },
                "SL" => new Country[] { Country.France },
                "SN" => new Country[] { Country.France },
                "SP" => new Country[] { Country.France },
                "SR" => new Country[] { Country.France },
                "TA" => new Country[] { Country.France },
                "TD" => new Country[] { Country.Italy },
                "TJ" => new Country[] { Country.France },
                "TH" => new Country[] { Country.France },
                "TN" => new Country[] { Country.France },
                "TR" => new Country[] { Country.France },
                "TS" => new Country[] { Country.France },
                "TX" => new Country[] { Country.USA },
                "UB" => new Country[] { Country.Spain },
                "VI" => new Country[] { Country.France },
                "VX" => new Country[] { Country.France },
                _ => Array.Empty<Country>()
            };
        }
    }
}
