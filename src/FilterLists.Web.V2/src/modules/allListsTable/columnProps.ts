import { ColumnProps } from "antd/lib/table";
import { List } from './List';

const nameof = <T>(name: Extract<keyof T, string>): string => name;

export const columnProps: ColumnProps<List>[] = [
    {
        title: 'Name',
        dataIndex: nameof<List>("name"),
        width: 200,
        fixed: 'left'
    },
    {
        title: 'Description',
        dataIndex: nameof<List>("description"),
        width: 400
    },
    {
        title: 'Languages',
        dataIndex: nameof<List>("languageIds"),
        width: 400
    },
    {
        title: 'Tags',
        dataIndex: nameof<List>("tagIds"),
        width: 400
    }
];
