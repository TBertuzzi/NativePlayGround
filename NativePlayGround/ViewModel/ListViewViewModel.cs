using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NativePlayGround.Model;

namespace NativePlayGround.ViewModel
{
    public class ListViewViewModel
    {
        public ObservableCollection<Grouping<char, User>> GroupedUsers { get;  set; }

        public ListViewViewModel(int num = 2000)
        {
            var rnd = new Random();
            var users = new List<User>();

            User user = new User();
            user.Name = "Bertuzzi";
            users.Add(user);

            user = new User();
            user.Name = "Bruna";
            users.Add(user);

            user = new User();
            user.Name = "Polly";
            users.Add(user);

            user = new User();
            user.Name = "Rodolfo";
            users.Add(user);

            user = new User();
            user.Name = "Lester";
            users.Add(user);

            user = new User();
            user.Name = "Adalberto";
            users.Add(user);

            user = new User();
            user.Name = "Thiago";
            users.Add(user);

            GroupedUsers = new ObservableCollection<Grouping<char, User>>(users.OrderBy(e => e.Name[0]).GroupBy(e => e.Name[0]).Select(e => new Grouping<char, User>(e.Key, e)));
        }
    }
}
