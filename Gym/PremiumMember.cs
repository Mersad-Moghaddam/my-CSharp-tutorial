using System;
namespace Gym
{
    internal class PremiumMember(string name, int age, int memberId, string email, string membershipPlan) : GymMember(name, age, memberId, email, membershipPlan) 
    {
        public override void RegisterMember()
        {
            Console.WriteLine($"Premium member {Name} registered with plan {MembershipPlan}.");
        }

        public override void CancelMembership()
        {
            Console.WriteLine($"Premium member {Name} with email {Email} has cancelled their membership.");
        }

        public override void UpdateMembership(string newPlan)
        {
            MembershipPlan = newPlan;
            Console.WriteLine($"Premium member {Name} updated their membership to {MembershipPlan}.");
        }

        public override void DisplayMembershipDetails()
        {
            Console.WriteLine($"Premium Member Details: {ToString()}");
        }
    }
}