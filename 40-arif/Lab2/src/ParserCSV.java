import java.io.File;
import java.io.FileNotFoundException;
import java.text.SimpleDateFormat;
import java.util.*;


public class ParserCSV {

    public static void main(String[] args){
        data();
    }

    File file;

    public static String data(){

        String path="/Users/mdarifulislam/design-patterns-swe-17/40-arif/Lab2/src/dataset.csv";
        File file= new File(path);

        try {
            Scanner sc= new Scanner(file);
            ArrayList<String> subList= new ArrayList<>();
            ArrayList<Date> dates= new ArrayList<>();
            int hour[];





            while (sc.hasNextLine()){
                String data= sc.nextLine();


                String[] charArr= data.split(",");

                StringTokenizer tokenizer = new StringTokenizer(data, ",");

                int i=0;
                while (tokenizer.hasMoreTokens()) {
                    if(i==0){
                        System.out.println(tokenizer.nextToken());
//                        subList.add(tokenizer.nextToken());
                    }if(i==1){
                        System.out.println(tokenizer.nextToken());
//                        Date date;
//                        try{
//                            date= new SimpleDateFormat("dd/MM/yyyy").parse(tokenizer.nextToken().toString());
//                            dates.add(date);
//                        }catch (Exception e){
//                            System.out.println("date error");
//                        }
                    }if(i==2){
                        System.out.println(tokenizer.nextToken());
//                        subList.add(tokenizer.nextToken());
                    }
                    i++;
                }







            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

        return "";
    }

}
