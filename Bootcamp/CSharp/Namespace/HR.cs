namespace HR
{
    public interface IEmployee
    {

    }

    public interface IExecutive : IEmployee
    {

    }
    public class Executive : IExecutive
    {

    }
    namespace Mgr
    {
        public interface IManager : IEmployee
        {

        }

        public class Manager : IManager
        {

        }
        public class AssistManager : IManager
        {

        }
    }

}