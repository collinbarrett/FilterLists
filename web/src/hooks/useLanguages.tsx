import { Language } from "../interfaces/Language";
import { useApiData } from "./useApiData";

export const useLanguages = () =>
  (useApiData<Language[]>("https://api.filterlists.com/languages") || []).sort(
    (a: Language, b: Language) => a.name.localeCompare(b.name),
  );
