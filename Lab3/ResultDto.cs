namespace Lab3
{
    /// <summary>
    /// Dto результат для одной строки в таблице
    /// </summary>
    public class ResultDto
    {
        /// <summary>
        /// уточняемые корни
        /// </summary>
        public (double, double) ApproximateRoots { get; set; }
        /// <summary>
        /// уточненные корни
        /// </summary>
        public (double, double) ApproximatedRoots { get; set; }
        /// <summary>
        /// норма вектора решений системы
        /// </summary>
        public double NormOfApproximatedCoordinatesVector { get; set; }
    }
}