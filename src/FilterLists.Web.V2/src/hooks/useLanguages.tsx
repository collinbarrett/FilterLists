import { Language } from '../interfaces/Language';
import { useApiData } from './useApiData';

export const useLanguages = () => useApiData<Language[]>("/api/v1/languages") || [];
