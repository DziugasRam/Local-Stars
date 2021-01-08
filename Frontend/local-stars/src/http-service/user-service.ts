import { HttpService } from "./http-service";

class Urls {
	public static readonly signIn = "/api/user/signin";
	public static readonly signOut = "/api/user/signOut";
	public static readonly register = "/api/user/register";
}

export class UserService {
	// TODO: move to seller/buyer service if possible and handle logout
	private static readonly sellerIdKey = "sellerId";
	private static readonly userIdKey = "userId";
	private static readonly buyerIdKey = "buyerId";

	public static async setSellerId(sellerId: string | null) {
		if (sellerId == null) localStorage.removeItem(this.sellerIdKey);
		else localStorage.setItem(this.sellerIdKey, sellerId);
	}

	public static getSellerId() {
		return localStorage.getItem(this.sellerIdKey);
	}

	public static async setUserId(userId: string | null) {
		if (userId == null) localStorage.removeItem(this.userIdKey);
		else localStorage.setItem(this.userIdKey, userId);
	}

	public static getUserId() {
		return localStorage.getItem(this.userIdKey);
	}

	public static async setBuyerId(buyerId: string | null) {
		if (buyerId == null) localStorage.removeItem(this.buyerIdKey);
		else localStorage.setItem(this.buyerIdKey, buyerId);
	}

	public static getBuyerId() {
		return localStorage.getItem(this.buyerIdKey);
	}

	public static isSignedIn() {
		return this.getUserId() != null;
	}

	public static setIds(respJson: any) {
		this.setSellerId(respJson[this.sellerIdKey]);
		this.setUserId(respJson[this.userIdKey]);
		this.setBuyerId(respJson[this.buyerIdKey]);
	}

	public static clearIds() {
		localStorage.removeItem(this.sellerIdKey);
		localStorage.removeItem(this.userIdKey);
		localStorage.removeItem(this.buyerIdKey);
	}

	public static async signIn(username: string, password: string) {
		const resp = await HttpService.post(Urls.signIn, {
			username: username,
			password: password,
		});
		if (resp.ok) {
			const json = await resp.json();
			this.setIds(json);
			document.location.href = document.location.origin;
			await new Promise(() => {});
		}
	}

	public static async signOut() {
		const resp = await HttpService.post(Urls.signOut);
		if (resp.ok) {
			this.clearIds();
		}
		return resp.ok;
	}

	public static async register(username: string, password: string) {
		const resp = await HttpService.post(Urls.register, {
			username: username,
			password: password,
		});
		if (resp.ok) {
			const json = await resp.json();
			this.setIds(json);
			document.location.href = `${document.location.origin}/register/seller`;
			await new Promise(() => {});
		}
	}
}
