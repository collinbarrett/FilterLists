import { List } from '../interfaces/List';
import { useApiData } from './useApiData';

export const useLists = () => useApiData<List[]>("/api/v1/lists") || [];
