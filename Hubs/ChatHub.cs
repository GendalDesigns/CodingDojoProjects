using ApartmentNetwork.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ApartmentNetwork.Hubs
{
    public class ChatHub : Hub
    {
        private readonly UserManager<User> userManager;
        public ChatHub(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        //*****// AJG Im trying to add in the BUILDING ID into the message so the receiving HTML knows which messages to display, as long as they match the sending Users's Building ID
        public async Task SendMessage(string user, string message, int bldgID)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async override Task OnConnectedAsync()
        {
            var user = await userManager.FindByNameAsync(Context.User.Identity.Name);
            Console.WriteLine("This is the user from ChatHub:" +user);
        }
    }
}

    // public class ChatHub : Hub
    // {
    //     private readonly UserManager<User> userManager;

    //     public ChatHub(UserManager<User> userManager)
    //     {
    //         this.userManager = userManager;
    //     }

    //     public async override Task OnConnectedAsync()
    //     {
    //         var user = await userManager.FindByNameAsync(Context.User.Identity.Name);
    //         Console.WriteLine("This is the user from ChatHub:" +user);
    //         // if (user != null)
    //         // {
    //             // if (user.UserType == UserType.Administrator)
    //             // {
    //             //     await AddToGroup("Administrators");
    //             // }
    //             // else if (user.UserType == UserType.Employee)
    //             // {
    //             //     await AddToGroup("Employees");
    //             // }
    //         // }
    //         // else
    //         // {
    //         //     await Clients.Caller.SendAsync("ReceiveNotification", "Connection Error", 0);
    //         // }
    //     }


    //     public async Task SendNotification(string group, string message, int messageType)
    //     {
    //         await Clients.Group(group).SendAsync("ReceiveNotification", message, messageType);
    //     }

    //     public async Task AddToGroup(string groupName)
    //     {
    //         await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
    //     }

    //     public async Task RemoveFromGroup(string groupName)
    //     {
    //         await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
    //     }
    // }