public class PrinterDriver
{
    private IInput input;
    private IPrinter printer;

    public PrinterDriver(IInput input, IPrinter printer){
        this.input = input;
        this.printer = printer;
    }

    public void Print(){
        Buffer page = this.input.GetNextPage();
        while(this.input.IsEndOfFile(page)){
            this.printer.Print(page);
            page = this.input.GetNextPage();
        }
    }
}

public Interface IInput{
    bool IsEndOfFile();
    Buffer GetNextPage();
}

public Interface IPrinter{
    void Print(Buffer);
}

public class PDFFile:IInput{
    private File file;
    public bool IsEndOfFile(){
        //...
    }

    public Buffer GetNextPage(){
        //...
    }
}

public class HP01Scanner:IInput{
    private Scanner scanner;
    public bool IsEndOfFile(){
        //...
    }

    public Buffer getNextPage(){
        //...
    }
}

public class HPPrinter:IPrinter{
    private Printer printer;
    public void Print(Buffer){
        //...
    }
}

public class CanonPrinter:IPrinter{
    private Printer printer;
    public void Print(Buffer){
        //...
    }
}
