using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioVRHT.Validation.Global.Estructura
{
    public struct ParametroPaginacion
    {
        public const int RowsPerPage = 10;
        public const int Page = 1;
        public const String SortDirDesc = "DESC";
        public const String SortDir = "ASC";
        public const String SortType = String.Empty;
        public const int RowCount = (int)Decimal.Zero;
        public const string OneRecords = "Un registro encontrado.";
        public const string MultipleRecords = "[{0}] Registros encontrados, mostrando del [{1}] al [{2}].";
    }
}
