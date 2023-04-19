namespace SpaceXDAL.ADO.HelperClasses
{
    public class RowsAffectedHelper
    {
        private int _RowsAffected;

        public int RowsAffected
        {
            get { return _RowsAffected; }
            set
            {
                _RowsAffected = value;
            }
        }
    }
}
