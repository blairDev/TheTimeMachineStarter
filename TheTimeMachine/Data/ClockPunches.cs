namespace TheTimeMachine.Data
{
    public class ClockPunches
    {
        private static List<ClockPunch> punches = new List<ClockPunch>();        

        public static List<ClockPunch> AllPunches
        {
            get { return punches; }
        }

        public static void AddPunch(ClockPunch punch)
        {
            punches.Add(punch);
        }

        public static List<ClockPunch> GetPunchesByUserId(int userId)
        {
            return punches.Where(p => p.UserId == userId).ToList();
        }

        public static List<ClockPunch> GetPunchByPunchId(int PunchId)
        {
            return punches.Where(p => p.Id == PunchId).ToList();
        }

        public static int DeletePunch(int punchId)
        {
            return punches.RemoveAll(p => p.Id == punchId);
        }

        public static bool UpdatePunch(ClockPunch punch)
        {            
            bool success = false;
            ClockPunch? punchToUpdate = punches.FirstOrDefault(p => p.Id == punch.Id);
            if (punchToUpdate != null)
            {
                //can only change punch code and punch time
                success = true;
                punchToUpdate.PunchCode = punch.PunchCode;
                punchToUpdate.UTCPunchDateTime = punch.UTCPunchDateTime;
            }
            return success;
        }

    }
}
