using System;
namespace Gym
{
    internal interface IGymMembership
    {
        void RegisterMember(string name, string email);
        void CancelMembership(string email);
        void UpdateMembership(string email, string newPlan);
        void DisplayMembershipDetails();
    }
}