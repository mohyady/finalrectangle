using Finalrectangle;

Console.WriteLine("Enter N value : ");
float N= Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter M value : ");
float M = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter C value : ");
float c= Convert.ToSingle(Console.ReadLine());
Console.WriteLine(" Enter h value : ");
float h= Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Enter b value : ");
float b = Convert.ToSingle(Console.ReadLine());

float d, dh;
d = h - c;
dh = d / h;

double p = (M * (Math.Pow(10, 6))) / (b * h * 2);
double q  = (N * (Math.Pow(10, 3))) / (b * h );

if (dh == 0.75F)
{
    //Load sample data
    var sampleData = new Rec075.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec075.Predict(sampleData);

    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }

}
else if (dh == 0.80F)
{

    //Load sample data
    var sampleData = new Rec080.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec080.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}

else if (dh == 0.85F)
{

    //Load sample data
    var sampleData = new Rec085.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec085.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}
else if (dh == 0.90F)
{
    //Load sample data
    var sampleData = new Rec090.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec090.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}
else if (dh == 0.95F)
{
    //Load sample data
    var sampleData = new Rec095.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec095.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}


else if (dh > 0.75F && dh < 0.80F)
{
    //Load sample data
    var sampleData = new Rec075080.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec075080.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}
else if (dh > 0.80F && dh < 0.85F)
{
    //Load sample data
    var sampleData = new Rec080085.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec080085.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}
else if (dh > 0.85F && dh < 0.90F)
{
    //Load sample data
    var sampleData = new Rec085090.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec085090.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}
else if (dh > 0.90F && dh < 0.95F)
{
    //Load sample data
    var sampleData = new Rec090095.ModelInput()
    {
        X = Convert.ToSingle(p),
        Y = Convert.ToSingle(q),
    };

    //Load model and predict output
    var result = Rec090095.Predict(sampleData);
    if (result.Score < 0.4F)
    {
        Console.WriteLine("0.4");
    }
    else
    {
        Console.WriteLine(result.Score);
    }
}