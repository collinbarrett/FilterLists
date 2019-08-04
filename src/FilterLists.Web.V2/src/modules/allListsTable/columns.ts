import { ColumnProps } from "antd/lib/table";
import { List } from './List';

export const columns: ColumnProps<List>[] = [
    {
        title: 'Name',
        dataIndex: 'name',
    }
];
