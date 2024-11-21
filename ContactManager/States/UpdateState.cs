namespace ContactManager.States
{
    internal class UpdateState : State
    {
        public UpdateState(Application application) : base(application)
        {
        }

        public override void Run()
        {
            try
            {
                Console.Write("Enter ID of contact to update: ");
                int id = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}