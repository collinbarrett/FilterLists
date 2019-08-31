import { useApiData } from '.';
import { License } from '../interfaces/License';

export const useLicenses = () => useApiData<License[]>("/api/v1/licenses") || [];
