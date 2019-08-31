import { useApiData } from '.';
import { List } from '../interfaces/List';

export const useLists = () => useApiData<List[]>("/api/v1/lists") || [];
