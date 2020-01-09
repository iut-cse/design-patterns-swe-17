import java.io.File;
import java.nio.file.Files;

public class MainClass {
    public static void main(String[] args){
        String path="/Users/mdarifulislam/design-patterns-swe-17/LAB/src/abc.sjson";
        File file= new File(path);

        Perser perser= getPerser(file);

        System.out.println("total Data Count: " +perser.count());
        System.out.println("Your data: "+perser.getString(2));


    }

    static Perser getPerser(File file){

        if(getFileExtension(file).equals("scsv")){
            return new SCSVPerser(file);
        }else if(getFileExtension(file).equals("sjson")){
            return new SJSONPerser(file);
        }else if(getFileExtension(file).equals("txt")){
            return new TXTperser(file);
        }else {
            System.out.println("Extension perse failed!");
            return null;
        }
    }

    private static String getFileExtension(File file) {
        String fileName = file.getName();
        if(fileName.lastIndexOf(".") != -1 && fileName.lastIndexOf(".") != 0)
            return fileName.substring(fileName.lastIndexOf(".")+1);
        else return "";
    }
}
