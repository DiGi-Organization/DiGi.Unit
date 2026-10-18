namespace DiGi.Unit.Enums
{
    /// <summary>
    /// Defines the supported units for solar radiation (irradiation) measurement - the energy received per unit area over a period, e.g. the yearly irradiation in kWh/m².
    /// </summary>
    [Classes.Category(UnitCategory.SolarRadiation)]
    public enum SolarRadiationUnit
    {
        /// <summary>
        /// Joule per square meter (SI derived unit), the category base.
        /// </summary>
        [Classes.FactorUnit("Joule per square meter", "J/m²", 1.0)] JoulePerSquareMeter,

        /// <summary>
        /// Kilowatt-hour per square meter - the irradiation in kWh/m².
        /// </summary>
        [Classes.FactorUnit("Kilowatt-hour per square meter", "kWh/m²", 3600000.0)] KilowattHourPerSquareMeter,
    }
}
