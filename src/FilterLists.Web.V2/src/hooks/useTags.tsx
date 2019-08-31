import { useApiData } from '.';
import { Tag } from '../interfaces/Tag';

export const useTags = () => useApiData<Tag[]>("/api/v1/tags") || [];
