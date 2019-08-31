import { useApiData } from '.';
import { Language } from '../interfaces/Language';

export const useLanguages = () => useApiData<Language[]>("/api/v1/languages") || [];
