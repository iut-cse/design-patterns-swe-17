public class SCSV_parser extends Parser{
    int count;
    String row_string;
    @Override
    public int getCount() {
        return count;
    }

    @Override
    public String getString() {
        return row_string;
    }
}
