using System.Text.Json;
using System.Text;

using System.Xml.Serialization;


public interface GenerateInvoiceFile{
    public void generateInvoiceFile(Invoice invoice);
}

public class GenerateJsonInvoiceFile : GenerateInvoiceFile{
    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\generateInvoice.json");
    public void generateInvoiceFile(Invoice invoice){
        try{
            using (FileStream fs = File.Create(this.path)){
                byte[] info = new UTF8Encoding(true).GetBytes(JsonSerializer.Serialize(invoice));
                fs.Write(info, 0, info.Length);
            }
        }catch (Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }
}
    
public class GenerateXmlInvoiceFile : GenerateInvoiceFile{
    string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\generateInvoice.xml");
    public void generateInvoiceFile(Invoice invoice){


        StringWriter result = new StringWriter();
        new System.Xml.Serialization.XmlSerializer(invoice.GetType()).Serialize(result,invoice);

        try{
            using (FileStream fs = File.Create(this.path)){
                byte[] info = new UTF8Encoding(true).GetBytes(result.ToString());
                fs.Write(info, 0, info.Length);
            }
        }catch (Exception ex){
            Console.WriteLine(ex.ToString());
        }
    }
}