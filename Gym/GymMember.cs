using System;
namespace Gym
{
    internal abstract class GymMember(string name, int age, int memberId, string email, string membershipPlan)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int MemberId { get; set; } = memberId;
        public string Email { get; set; } = email;
        public string MembershipPlan { get; set; } = membershipPlan;

        public abstract void RegisterMember();
        public abstract void CancelMembership();
        public abstract void UpdateMembership(string newPlan);
        public abstract void DisplayMembershipDetails();

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Member ID: {MemberId}, Email: {Email}, Membership Plan: {MembershipPlan}";
        }
    }
}