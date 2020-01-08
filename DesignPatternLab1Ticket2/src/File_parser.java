public class File_parser {
    String file_extension;
    Parser getParser(){
        if(file_extension == "sjson"){
            return new SJSON_parser();
        }
        else if(file_extension == "scsv"){
            return new SCSV_parser();
        }

        return null;
    }
}
