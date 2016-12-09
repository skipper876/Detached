﻿using EntityFrameworkCore.Detached.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Detached.Demo.Controllers
{
    public class UserController : ControllerBase<DemoContext, User, UserQuery>
    {
        public UserController(IDetachedContext<DemoContext> detachedContext) 
            : base(detachedContext)
        {
        }
    }
}
