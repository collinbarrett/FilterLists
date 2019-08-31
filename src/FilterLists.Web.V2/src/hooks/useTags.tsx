import { Tag } from '../interfaces/Tag';
import { useApiData } from './useApiData';

export const useTags = () => useApiData<Tag[]>("/api/v1/tags") || [];
