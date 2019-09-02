import { Syntax } from '../interfaces/Syntax';
import { useApiData } from './useApiData';

export const useSyntaxes = () => (useApiData<Syntax[]>("/api/v1/syntaxes") || [])
    .sort((a: Syntax, b: Syntax) => a.name.localeCompare(b.name));