import { ListDetails } from "../interfaces/ListDetails";
import { useApiData } from "./useApiData";

export const useListDetails = (id: number) => {
  return useApiData<ListDetails>("/api/v1/lists/" + id);
};
