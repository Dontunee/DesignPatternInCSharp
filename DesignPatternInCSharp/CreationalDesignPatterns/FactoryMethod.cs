using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.CreationalDesignPatterns
{
    interface IInterviewer
    {
        void AskQuestions();
    }

    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Ask about design patterns");
        }
    }

    class CommunityExecutive : IInterviewer
    {
        public void AskQuestions ()
        {
            Console.WriteLine("Äsking about community building");
        }
    }

    abstract class HiringManager
    {
        //Factory Method
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            var interviewer = MakeInterviewer();
            interviewer.AskQuestions();
        }
    }

    class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }

    }

    class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }

    //How it can be used
    //var devManager = new DevelopmentManager();
    //devManager.TakeInterview();

    //var marketingManager = new MarketingManager();
    //marketingManager.TakeInterview();
}
