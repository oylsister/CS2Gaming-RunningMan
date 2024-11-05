namespace RunningMan
{
    public class PlayerDistanceCount
    {
        public PlayerDistanceCount(float distance = 0, bool complete = false)
        {
            _distance = distance;
            _complete = complete;
        }

        private float _distance;
        private bool _complete;

        public float Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }

    public class PlayerData : PlayerDistanceCount
    {
        public PlayerData(string achieve, string reset, float count, bool complete = true)
        {
            _timeAcheived = achieve;
            _timeReset = reset;

            Distance = count;
            Complete = complete;
        }

        private string _timeAcheived;
        private string _timeReset;

        public string TimeAcheived
        {
            get { return _timeAcheived; }
            set { _timeAcheived = value; }
        }

        public string TimeReset
        {
            get { return _timeReset; }
            set { _timeReset = value; }
        }
    }
}
