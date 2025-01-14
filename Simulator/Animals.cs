﻿namespace Simulator;

public class Animals
{
        private string _description = ":D";
        
        public string Description 
        {
            get => _description;
            init
            {
                _description = value;
                _description = _description.Trim();
                if (_description.Length > 15)
                {
                    _description = _description[..15].TrimEnd();
                }
                if (_description.Length < 3)
                {
                    _description = _description.PadRight(3, '#');
                }

            _description = char.ToUpper(_description[0]) + _description[1..];
            }
        }
       
        public uint Size { get; set; } = 3;

        public virtual string Info => $"{Description} <{Size}>";

        public  override string ToString()
            {
                return $"{GetType().Name.ToUpper()}: {Info}";
            }
}

