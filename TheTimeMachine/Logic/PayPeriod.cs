using TheTimeMachine.Data;

namespace TheTimeMachine.Logic
{
    public class PayPeriod
    {
        public double CalculateTotalHours(int userId)
        {
            double TotalHours = 0;
            // Get all punches for the user
            List<ClockPunch> userPunches = ClockPunches.GetPunchesByUserId(userId);
            // Sort the punches by date for this user
            userPunches.Sort((x, y) => DateTime.Compare(x.UTCPunchDateTime, y.UTCPunchDateTime));
            // Loop through the punches and calculate the total hours
            for (int i = 0; i < userPunches.Count; i++)
            {
                // If the punch is a clock in, add the time to the total
                if (userPunches[i].PunchCode == "CI")
                {
                    // If the next punch is a clock out, calculate the time between the two punches
                    if (userPunches[i + 1].PunchCode == "CO")
                    {
                        // Calculate the time between the two punches
                        // Add the time to the total hours                        
                    }                    
                }
            }
            return TotalHours;
        }
    }
}
