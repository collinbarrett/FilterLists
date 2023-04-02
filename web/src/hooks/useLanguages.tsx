import { Language } from "../interfaces/Language";
import { useApiData } from "./useApiData";

export const useLanguages = () =>
  (useApiData<Language[]>("/api/languages") || []).sort(
    (a: Language, b: Language) => a.name.localeCompare(b.name)
  );
