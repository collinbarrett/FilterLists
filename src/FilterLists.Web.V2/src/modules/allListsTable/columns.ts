import { ColumnProps } from "antd/lib/table";
import { List } from './List';

const nameof = <T>(name: Extract<keyof T, string>): string => name;

export const columns: ColumnProps<List>[] = [
    {
        title: 'Name',
        dataIndex: nameof<List>("name")
    },
    {
        title: 'Description',
        dataIndex: nameof<List>("description")
    },
    {
        title: 'Languages',
        dataIndex: nameof<List>("languageIds")
    },
    {
        title: 'Tags',
        dataIndex: nameof<List>("tagIds")
    }
];
