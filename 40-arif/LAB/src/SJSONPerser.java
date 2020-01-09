import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class SJSONPerser extends Perser {

    File file;

    public SJSONPerser(File file){
        this.file= file;
    }

    @Override
    int count() {

        try {
            Scanner sc= new Scanner(file);
            int counter=0;
            while (sc.hasNextLine()){
                String data=sc.nextLine();
                String[] charArr= data.split("(?!^)");

                for (int i=0;i<data.length();i++) {
                    if(charArr[i].equals("=")){
                        counter++;
                    }
                }
            }
            if(counter!=0){
                return counter+1;
            }
            return counter;
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return 0;
    }

    @Override
    String getString(int i) {
        try {
            Scanner sc= new Scanner(file);
            int counter=0;
            String alldata="";
            while (sc.hasNextLine()){
                String data=sc.nextLine();
                alldata=alldata+data;
                String[] charArr= data.split("(?!^)");
                for (int j=0;j<data.length();j++) {
                    if(charArr[j].equals("=")){
                        counter=counter+1;
                        if(counter==i){
                            return alldata;
                        }else {
                            alldata="";
                        }
                    }
                }
            }
            return alldata;
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return null;
    }
}
