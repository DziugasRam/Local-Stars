import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";

export enum ContentType {
	json = "application/json",
	form = "multipart/form-data",
}

export class HttpService {
	private static baseUrl: string = serverUrl;

	public static post(relativeUrl: string, data: any = null, contentType: ContentType = ContentType.json) {
		const requestOptions: RequestInit = {
			method: "POST",
			headers: {
				"Content-Type": contentType,
			},
			body: JSON.stringify(data),
		};
		return authFetch(`${this.baseUrl}${relativeUrl}`, requestOptions);
	}

	public static delete(relativeUrl: string, data: any = null, contentType: ContentType = ContentType.json) {
		const requestOptions: RequestInit = {
			method: "DELETE",
			headers: {
				"Content-Type": contentType,
			},
			body: JSON.stringify(data),
		};
		return authFetch(`${this.baseUrl}${relativeUrl}`, requestOptions);
	}

	public static put(relativeUrl: string, data: any = null, contentType: ContentType = ContentType.json) {
		const requestOptions: RequestInit = {
			method: "PUT",
			headers: {
				"Content-Type": contentType,
			},
			body: JSON.stringify(data),
		};
		return authFetch(`${this.baseUrl}${relativeUrl}`, requestOptions);
	}
}
