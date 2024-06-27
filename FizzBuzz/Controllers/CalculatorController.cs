using FizzBuzz.Models;
using FizzBuzz.Models.Dtos;
using FizzBuzz.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NUnit.Framework;

namespace FizzBuzz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _icalculator;
        public CalculatorController(ICalculator icalculator)
        {
            _icalculator = icalculator;
        }
        [HttpPost]
        [Route("GetInput")]
        public ResponseDTO getInput([FromBody] ipResult[] objipResult)
        {
            ResponseDTO responseDTO = new ResponseDTO();
            try
            {
                string Msg1 = string.Empty;
                string Msg2 = string.Empty;
                string finalMsg = string.Empty;
                string finalResp = string.Empty;
                foreach (var numCheck in objipResult)
                {
                    var isNumeric1 = int.TryParse(numCheck.numRes1, out int a);
                    var isNumeric2 = int.TryParse(numCheck.numRes2, out int b);
                    var isNumeric3 = int.TryParse(numCheck.numRes3, out int c);
                    var isNumeric4 = int.TryParse(numCheck.numRes4, out int d);
                    var isNumeric5 = int.TryParse(numCheck.numRes5, out int e);
                    var isNumeric6 = int.TryParse(numCheck.numRes6, out int f);
                    var isNumeric7 = int.TryParse(numCheck.numRes7, out int g);
                    if (isNumeric1 == false)
                    {
                        Msg1 = "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes1) + ",";
                    }
                    if (isNumeric2 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes2) + ","; ;
                    }
                    if (isNumeric3 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes3) + ","; ;
                    }
                    if (isNumeric4 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes4) + ","; ;
                    }
                    if (isNumeric5 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes5) + ","; ;
                    }
                    if (isNumeric6 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes6) + ","; ;
                    }
                    if (isNumeric7 == false)
                    {
                        finalResp += "Invalid Item" + ",";
                    }
                    else
                    {
                        finalResp += _icalculator.chkNum(numCheck.numRes7);
                    }
                }
                if (finalResp != null)
                {
                    responseDTO.IsSuccess = true;
                    responseDTO.ResponseObject += finalResp;
                }
                else
                {
                    responseDTO.IsSuccess = false;
                    ErrorDTO errorDTO = new ErrorDTO();
                    errorDTO.ErrorCode = 100;
                    errorDTO.ErrorMessage = "Invalid UserID";
                    responseDTO.ErrorDTOs.Add(errorDTO);
                }
                return responseDTO;
            }
            catch (Exception ex)
            {
                responseDTO = new ResponseDTO();
                return responseDTO;
            }
        }
    }
}
