﻿namespace AluguelDeCarro.Application
{
    public class ResultModel
    {
        public object? Value { get; set; }
        public bool Error { get; set; }
        public string ErrorMessage { get; set; }

        public ResultModel() { }

        public ResultModel(object value)
        {
            Value = value;
            Error = false;
            ErrorMessage = string.Empty;
        }

        public ResultModel(string errorMessage)
        {
            Value = null;
            Error = true;
            ErrorMessage = errorMessage;
        }

        public static ResultModel resultSucess(string value)
        {
            return new ResultModel { Value = value, Error = false, ErrorMessage = string.Empty };
        }
    }
}
