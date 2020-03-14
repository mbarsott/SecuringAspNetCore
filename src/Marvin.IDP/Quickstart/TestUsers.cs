// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Marvin.IDP
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser{SubjectId = "F656787C-E364-46B5-8321-4BAEAA9A2965", Username = "Frank", Password = "password", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.GivenName, "Frank"),
                    new Claim(JwtClaimTypes.FamilyName, "Underwood")
                }
            },
            new TestUser{SubjectId = "0818D42B-9DF1-4824-9C14-C487FE4D9311", Username = "Claire", Password = "password", 
                Claims = 
                {
                    new Claim(JwtClaimTypes.GivenName, "Claire"),
                    new Claim(JwtClaimTypes.FamilyName, "Underwood")
                }
            }
        };
    }
}