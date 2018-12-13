using AOE.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.Service
{
    static class ResourcesService
    {
        public static void AssignResources(Villager villager, ResourceType? resource)
        {
            villager.Harvesting = resource;
        }
    }
}
