import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class TXTperser extends Perser {

    File file;

    public TXTperser(File file){
        this.file= file;
    }
    @Override
    int count() {

        try {
            Scanner sc= new Scanner(file);
            int counter=0;
            while (sc.hasNextLine()){
                sc.nextLine();
                counter++;
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
            while (sc.hasNextLine()){
                String data= sc.nextLine();
                if(counter==i){
                    return data;
                }
                counter++;
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return null;
    }
}
