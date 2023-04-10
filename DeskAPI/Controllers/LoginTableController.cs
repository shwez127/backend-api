﻿using DeskBusiness.Services;
using DeskEntity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DeskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginTableController : ControllerBase
    {
        //Private member
        LoginTableService _loginTableService;
        private readonly ILogger<LoginTableController> _logger; 

        //Constructor
        public LoginTableController(LoginTableService loginTableService)
        {
            _loginTableService = loginTableService;
        }

        [HttpPost("Login")]
        public int[] Login(LoginTable loginTable)
        {
            try
            {
                #region Role based login as admin and employee
                int[] flag = _loginTableService.Login(loginTable);
                if (flag[1] == 3)
                {
                    return flag;
                }
                else
                if (flag[1] == 0)
                {
                    return flag;
                }

                return null;
                #endregion
            }
            catch (NullReferenceException)
            {
                _logger.LogInformation("Logging demo");
                _logger.LogWarning("logging Warning");
                _logger.LogError("Log Errror");
                _logger.LogCritical("Email Log");
                return null;
            }
        }

        [HttpPost("AddLogin")]
        public int AddLogin(LoginTable loginTable)
        {
            #region Login adding action
            int flag = _loginTableService.AddLogin(loginTable);
            if (flag != 0)
                return flag;
            return 0;
            #endregion
        }

        [HttpPost("ForgetPassword")]
        public LoginTable ForgetPassword(LoginTable login)
        {
            #region Forget password action
            return _loginTableService.ForgetPassword(login);
            #endregion
        }

        [HttpPut("UpdatePassword")]
        public void UpdatePassword(LoginTable login)
        {
            #region Updating password in forget password action
            _loginTableService.UpdatePassword(login);
            #endregion
        }
    }
}
