public class SJSON_parser extends Parser {
    int count;
    String row_String;

    @Override
    public int getCount() {
        return count;
    }

    @Override
    public String getString() {
        return row_String;
    }
}
