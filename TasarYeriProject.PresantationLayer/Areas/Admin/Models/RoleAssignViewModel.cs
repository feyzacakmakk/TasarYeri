﻿namespace TasarYeriProject.PresantationLayer.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool Exists { get; set; }//bu kullanıcı bu rolü içeriyor mu
    }
}
