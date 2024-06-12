import { ListDetails } from "../interfaces/ListDetails";
import { useApiData } from "./useApiData";

export const useListDetails = (id: number) => {
  return useApiData<ListDetails>("https://api.filterlists.com/lists/" + id);
};
