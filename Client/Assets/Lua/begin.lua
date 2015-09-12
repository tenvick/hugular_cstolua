------------------------------------------------
--  Copyright © 2013-2014   Hugula: Arpg game Engine
--   
--  author pu
------------------------------------------------
require("const.importClass")
require("net.netMsgHelper")
require("net.netAPIList")
require("net.netProtocalPaser")
require("net.proxy")
require("const.requires")
require("registerItemObjects")
require("registerState")
require("uiInput")

-- local os=os
-- local UPDATECOMPONENTS=UPDATECOMPONENTS
-- local LuaObject=LuaObject
-- local StateManager=StateManager
-- local Net=Net
-- local Msg=Msg
-- local LuaHelper = LuaHelper
-- local delay = delay

-- -------------------------------------------------------------------------------

-- local Proxy=Proxy
-- local NetMsgHelper = NetMsgHelper
-- local NetAPIList = NetAPIList

StateManager:setCurrentState(StateManager.welcome)

-- require("netGame")

--local function disposeFirst( ... )
--	local fristView = LuaHelper.Find("Frist")
--	if fristView then LuaHelper.Destroy(fristView) end
----	fristView = nil 
--end

--delay(disposeFirst,1,nil)