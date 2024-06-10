﻿using RandomNumberGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RandomNumberGenerator.Commands;

public class NewDataCommand : CommandBase
{
    public override bool CanExecute(object? parameter) => (parameter as RandomData) != null;

    public override void Execute(object? parameter)
    {
        ((RandomData)parameter).GetRandomData();
    }
}
